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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
		public override Stats BaseStats => new Stats(70, 60, 125, 115, 70, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Crunch() },
			[1] = new List<Move>() { new Moves.Crunch(), new Moves.Bind(), new Moves.Withdraw(), new Moves.Rollout(), new Moves.Sandattack() },
			[15] = new List<Move>() { new Moves.Watergun() },
			[20] = new List<Move>() { new Moves.Leer() },
			[25] = new List<Move>() { new Moves.Mudshot() },
			[30] = new List<Move>() { new Moves.Ancientpower() },
			[35] = new List<Move>() { new Moves.Brine() },
			[43] = new List<Move>() { new Moves.Protect() },
			[49] = new List<Move>() { new Moves.Rockblast() },
			[56] = new List<Move>() { new Moves.Surf() },
			[63] = new List<Move>() { new Moves.Shellsmash() },
			[70] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Crunch(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Liquidation(), new Moves.Meteorbeam(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Pinmissile(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Toxicspikes(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
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