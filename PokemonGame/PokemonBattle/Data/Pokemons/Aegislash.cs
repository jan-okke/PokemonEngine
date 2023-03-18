using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Aegislash : Pokemon
	{
		public override string Name => "Aegislash";
		public override List<Ability> AvailableAbilities => new() {new Stancechange() };
		public override Stats BaseStats => new Stats(60, 50, 140, 50, 140, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Kingsshield() },
			[1] = new List<Move>() { new Kingsshield(), new Headsmash(), new Aerialace(), new Metalsound(), new Slash(), new Nightslash(), new Retaliate(), new Irondefense(), new Ironhead(), new Powertrick(), new Swordsdance(), new Sacredsword(), new Tackle(), new Furycutter(), new Shadowsneak(), new Autotomize() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Attract(), new Brickbreak(), new Brutalswing(), new Closecombat(), new Endure(), new Facade(), new Falseswipe(), new Flashcannon(), new Gigaimpact(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Protect(), new Psychocut(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Reversal(), new Rockslide(), new Round(), new Screech(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarblade(), new Steelbeam(), new Substitute(), new Sunnyday(), new Swordsdance() };
		public override int Weight => 530;
		public override int ExpYield => 250;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}