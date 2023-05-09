using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cloyster : Pokemon
{
	public override string Name => "Cloyster";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shellarmor(), new Abilities.Skilllink() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
	public override Stats BaseStats => new Stats(50, 95, 180, 85, 45, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Iciclespear() },
		[1] = new List<Move>() { new Moves.Iciclespear(), new Moves.Iciclecrash(), new Moves.Toxicspikes(), new Moves.Spikes(), new Moves.Leer(), new Moves.Whirlpool(), new Moves.Supersonic(), new Moves.Aurorabeam(), new Moves.Protect(), new Moves.Razorshell(), new Moves.Irondefense(), new Moves.Icebeam(), new Moves.Shellsmash(), new Moves.Hydropump(), new Moves.Tackle(), new Moves.Watergun(), new Moves.Withdraw(), new Moves.Iceshard() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Round(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Spikes(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Torment(), new Moves.Toxicspikes(), new Moves.Triattack(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool() };
	public override int Weight => 1325;
	public override int ExpYield => 184;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}