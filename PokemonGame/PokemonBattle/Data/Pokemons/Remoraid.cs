using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Remoraid : Pokemon
	{
		public override string Name => "Remoraid";
		public override List<Ability> AvailableAbilities => new() {new Hustle(), new Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moody() };
		public override Stats BaseStats => new Stats(35, 65, 35, 65, 35, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Helpinghand() },
			[4] = new List<Move>() { new Waterpulse() },
			[8] = new List<Move>() { new Focusenergy() },
			[12] = new List<Move>() { new Psybeam() },
			[16] = new List<Move>() { new Aurorabeam() },
			[20] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Lockon() },
			[28] = new List<Move>() { new Bulletseed() },
			[32] = new List<Move>() { new Icebeam() },
			[36] = new List<Move>() { new Hydropump() },
			[40] = new List<Move>() { new Soak() },
			[44] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Blizzard(), new Bounce(), new Brine(), new Bulletseed(), new Chargebeam(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Focusenergy(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Mudshot(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Rockblast(), new Round(), new Scald(), new Screech(), new Seedbomb(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Thief(), new Thunderwave(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Acidspray(), new Aurorabeam(), new Entrainment(), new Flail(), new Haze(), new Mudshot(), new Octazooka(), new Rockblast(), new Screech(), new Snore(), new Supersonic(), new Swift(), new Waterspout() };
		public override int Weight => 120;
		public override int ExpYield => 60;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}