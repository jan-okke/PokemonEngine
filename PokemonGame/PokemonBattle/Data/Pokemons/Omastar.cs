using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Omastar : Pokemon
	{
		public override string Name => "Omastar";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(70, 60, 125, 115, 70, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Crunch() },
			[1] = new List<Move>() { new Crunch(), new Bind(), new Withdraw(), new Rollout(), new Sandattack() },
			[15] = new List<Move>() { new Watergun() },
			[20] = new List<Move>() { new Leer() },
			[25] = new List<Move>() { new Mudshot() },
			[30] = new List<Move>() { new Ancientpower() },
			[35] = new List<Move>() { new Brine() },
			[43] = new List<Move>() { new Protect() },
			[49] = new List<Move>() { new Rockblast() },
			[56] = new List<Move>() { new Surf() },
			[63] = new List<Move>() { new Shellsmash() },
			[70] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Crunch(), new Dive(), new Doubleteam(), new Earthpower(), new Endure(), new Facade(), new Gigaimpact(), new Gyroball(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Liquidation(), new Meteorbeam(), new Muddywater(), new Mudshot(), new Pinmissile(), new Protect(), new Raindance(), new Rest(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scald(), new Sleeptalk(), new Snore(), new Spikes(), new Stealthrock(), new Stoneedge(), new Substitute(), new Surf(), new Swagger(), new Thief(), new Toxicspikes(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 350;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
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