using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.AI
{
    public static class BattleAI
    {
        public static Move AIChooseMove(this Battle battle)
        {
            var pokemon =  battle.EnemyParty.GetFirstAlivePokemon();
            // this is just max dmg base power move for now.
            return pokemon.GetHighestBPMoves()[0];
        }

    	public static Move GetBestMove(this Battle battle) {
            var pokemon = battle.EnemyParty.GetFirstAlivePokemon();
            var opponent = battle.PlayerParty.GetFirstAlivePokemon();

            var enemySide = battle.PlayerSide;

            // Check OHKOs
            foreach (Move m in pokemon.Moves) {
                if (CanOHKO(battle, m)) {
                    return m;
                }
            }
            // check if enemy can ohko
            foreach (Move m in opponent.Moves) {
                if (CanOppOHKO(battle, m)) {
                    foreach (Move aiM in pokemon.Moves) {
                        if (aiM.Priority > m.Priority) {
                            return aiM;
                        }
                    }
                }
            }
            // check if should set up entry hazards
            if (pokemon.CanSetupToxicSpikes() && enemySide.GetHazardCount(Hazard.ToxicSpikes) < 2) {
                if (ShouldUseHazards(battle, Hazard.ToxicSpikes)) {
                    return pokemon.FindMove("Toxic Spikes");
                }
            }
            if (pokemon.CanSetupRocks() & !enemySide.HasHazard(Hazard.StealthRock)) {
                if (ShouldUseHazards(battle, Hazard.StealthRock)) {
                    return pokemon.FindMove("Stealth Rocks");
                }
            }
            if (pokemon.CanSetupSpikes() && enemySide.GetHazardCount(Hazard.Spikes) < 3) {
                if (ShouldUseHazards(battle, Hazard.Spikes)) {
                    return pokemon.FindMove("Spikes");
                }
            }

            // if cant ohko check if should lower speed
            if (opponent.IsFaster(pokemon)) {
                foreach (Move m in pokemon.Moves) {
                    if (m.DoesLowerSpeed() && m.AffectsPokemon(pokemon, opponent)) {
                        return m;
                    }
                }
            }                                                                                                                                                                          
            // check if can 2hko
            foreach (Move m in pokemon.Moves) {
                if (Can2HKO(battle, m)) {
                    return m;
                }
            }
            // if has status condition move, use it
            foreach (Move m in pokemon.Moves) {
                if (m.AffectsPokemon(pokemon, opponent) & !opponent.HasAbility("Guts")) {
                    // check if status condition is useful
                }
            }
            // 
            return pokemon.GetHighestBPMoves().First();
        }

        private static bool CanOHKO(Battle battle, Move move) {
            var opponent = battle.PlayerParty.GetFirstAlivePokemon();
            return CalculateDamage(battle, move) > opponent.CurrentHP;
        }
        private static bool CanOppOHKO(Battle battle, Move move) {
            var user = battle.EnemyParty.GetFirstAlivePokemon();
            return battle.CalculateDamage(true, move).Value > user.CurrentHP;
        }
        private static bool Can2HKO(Battle battle, Move move) {
            var opponent = battle.PlayerParty.GetFirstAlivePokemon();
            return CalculateDamage(battle, move) > opponent.CurrentHP / 2;
        }
        private static int CalculateDamage(Battle battle, Move move) => battle.CalculateDamage(false, move).Value;

        private static bool ShouldUseHazards(Battle battle, Hazard hazard) {
            // assumes enemy side doesnt have hazards already
            var oppParty = battle.PlayerParty;
            var opponent = oppParty.GetFirstAlivePokemon();

            if (opponent.HasAbility("Magic Bounce") || opponent.HasMove("Magic Coat")) return false; // reflecting hazards
            double damageValuePercent = 0;
            foreach (Pokemon p in oppParty.Pokemons) {
                if (!(p.HasAbility("Levitate") && (hazard == Hazard.Spikes || hazard == Hazard.ToxicSpikes)))
                    damageValuePercent += p.GetDamagePercentageFromHazard(hazard);
                if (p.HasMove("Rapid Spin", "Defog")) return false;
            }
            return damageValuePercent > 50;
            
        }
    }
}
