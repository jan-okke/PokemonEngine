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
		public override List<Ability> AvailableAbilities => new() {new Earlybird(), new Scrappy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(105, 95, 80, 40, 80, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Tailwhip() },
			[4] = new List<Move>() { new Growl() },
			[8] = new List<Move>() { new Fakeout() },
			[12] = new List<Move>() { new Bite() },
			[16] = new List<Move>() { new Stomp() },
			[20] = new List<Move>() { new Focusenergy() },
			[24] = new List<Move>() { new Headbutt() },
			[28] = new List<Move>() { new Suckerpunch() },
			[32] = new List<Move>() { new Doublehit() },
			[36] = new List<Move>() { new Crunch() },
			[40] = new List<Move>() { new Endure() },
			[44] = new List<Move>() { new Reversal() },
			[48] = new List<Move>() { new Outrage() },
			[52] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Assurance(), new Attract(), new Avalanche(), new Beatup(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Reversal(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Terrainpulse(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Uproar(), new Waterpulse(), new Whirlpool(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Circlethrow(), new Counter(), new Crushclaw(), new Disable(), new Doubleedge(), new Endeavor(), new Focusenergy(), new Hammerarm(), new Stomp(), new Uproar() };
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