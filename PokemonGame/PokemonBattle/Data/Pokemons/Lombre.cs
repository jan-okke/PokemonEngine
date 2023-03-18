using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lombre : Pokemon
	{
		public override string Name => "Lombre";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Raindish() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Owntempo() };
		public override Stats BaseStats => new Stats(60, 50, 50, 50, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Teeterdance(), new Fakeout(), new Knockoff(), new Flail(), new Astonish(), new Growl(), new Absorb(), new Watergun() },
			[9] = new List<Move>() { new Mist() },
			[12] = new List<Move>() { new Megadrain() },
			[18] = new List<Move>() { new Furyswipes() },
			[24] = new List<Move>() { new Bubblebeam() },
			[30] = new List<Move>() { new Naturepower() },
			[36] = new List<Move>() { new Gigadrain() },
			[43] = new List<Move>() { new Raindance() },
			[50] = new List<Move>() { new Zenheadbutt() },
			[57] = new List<Move>() { new Energyball() },
			[64] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulletseed(), new Dive(), new Doubleteam(), new Drainpunch(), new Encore(), new Endure(), new Energyball(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Hail(), new Hiddenpower(), new Hydropump(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Megakick(), new Megapunch(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Scald(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Thunderpunch(), new Uproar(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Zenheadbutt() };
		public override int Weight => 325;
		public override int ExpYield => 119;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}