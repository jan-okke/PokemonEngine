using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cloyster : Pokemon
	{
		public override string Name => "Cloyster";
		public override List<Ability> AvailableAbilities => new() {new Shellarmor(), new Skilllink() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(50, 95, 180, 70, 85, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Iciclespear() },
			[1] = new List<Move>() { new Iciclespear(), new Iciclecrash(), new Toxicspikes(), new Spikes(), new Leer(), new Whirlpool(), new Supersonic(), new Aurorabeam(), new Protect(), new Razorshell(), new Irondefense(), new Icebeam(), new Shellsmash(), new Hydropump(), new Tackle(), new Watergun(), new Withdraw(), new Iceshard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Brine(), new Dive(), new Doubleteam(), new Endure(), new Explosion(), new Facade(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Iciclespear(), new Icywind(), new Irondefense(), new Lightscreen(), new Liquidation(), new Mudshot(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Rockblast(), new Round(), new Screech(), new Selfdestruct(), new Sleeptalk(), new Smartstrike(), new Snore(), new Spikes(), new Steelroller(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Torment(), new Toxicspikes(), new Triattack(), new Waterpulse(), new Weatherball(), new Whirlpool() };
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
}