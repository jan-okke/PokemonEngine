using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kangaskhan : Pokemon
	{
		public override string Name => "Kangaskhan";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Earlybird(), new Abilities.Scrappy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
		public override Stats BaseStats => new Stats(105, 95, 80, 40, 80, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound(), new Moves.Tailwhip() },
			[4] = new List<Move>() { new Moves.Growl() },
			[8] = new List<Move>() { new Moves.Fakeout() },
			[12] = new List<Move>() { new Moves.Bite() },
			[16] = new List<Move>() { new Moves.Stomp() },
			[20] = new List<Move>() { new Moves.Focusenergy() },
			[24] = new List<Move>() { new Moves.Headbutt() },
			[28] = new List<Move>() { new Moves.Suckerpunch() },
			[32] = new List<Move>() { new Moves.Doublehit() },
			[36] = new List<Move>() { new Moves.Crunch() },
			[40] = new List<Move>() { new Moves.Endure() },
			[44] = new List<Move>() { new Moves.Reversal() },
			[48] = new List<Move>() { new Moves.Outrage() },
			[52] = new List<Move>() { new Moves.Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Assurance(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Beatup(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Terrainpulse(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Circlethrow(), new Moves.Counter(), new Moves.Crushclaw(), new Moves.Disable(), new Moves.Doubleedge(), new Moves.Endeavor(), new Moves.Focusenergy(), new Moves.Hammerarm(), new Moves.Stomp(), new Moves.Uproar() };
		public override int Weight => 800;
		public override int ExpYield => 172;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}