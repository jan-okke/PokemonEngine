using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lotad : Pokemon
	{
		public override string Name => "Lotad";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Raindish() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Owntempo() };
		public override Stats BaseStats => new Stats(40, 30, 30, 30, 40, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Growl() },
			[3] = new List<Move>() { new Absorb() },
			[6] = new List<Move>() { new Watergun() },
			[9] = new List<Move>() { new Mist() },
			[12] = new List<Move>() { new Megadrain() },
			[16] = new List<Move>() { new Flail() },
			[20] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Naturepower() },
			[28] = new List<Move>() { new Gigadrain() },
			[33] = new List<Move>() { new Raindance() },
			[38] = new List<Move>() { new Zenheadbutt() },
			[43] = new List<Move>() { new Energyball() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Bulletseed(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Uproar(), new Waterpulse(), new Whirlpool(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Flail(), new Leechseed(), new Razorleaf(), new Sweetscent(), new Synthesis(), new Teeterdance(), new Tickle(), new Watergun() };
		public override int Weight => 26;
		public override int ExpYield => 44;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}