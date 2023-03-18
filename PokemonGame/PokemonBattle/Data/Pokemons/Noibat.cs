using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Noibat : Pokemon
	{
		public override string Name => "Noibat";
		public override List<Ability> AvailableAbilities => new() {new Frisk(), new Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(40, 30, 35, 55, 45, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Flying, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Absorb() },
			[4] = new List<Move>() { new Gust() },
			[8] = new List<Move>() { new Supersonic() },
			[12] = new List<Move>() { new Doubleteam() },
			[16] = new List<Move>() { new Wingattack() },
			[20] = new List<Move>() { new Bite() },
			[24] = new List<Move>() { new Aircutter() },
			[28] = new List<Move>() { new Whirlwind() },
			[32] = new List<Move>() { new Superfang() },
			[36] = new List<Move>() { new Airslash() },
			[40] = new List<Move>() { new Screech() },
			[44] = new List<Move>() { new Roost() },
			[49] = new List<Move>() { new Tailwind() },
			[52] = new List<Move>() { new Hurricane() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Airslash(), new Attract(), new Brickbreak(), new Darkpulse(), new Dracometeor(), new Dragonpulse(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hypervoice(), new Irontail(), new Leechlife(), new Outrage(), new Protect(), new Psychic(), new Rest(), new Round(), new Screech(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Thief(), new Uproar(), new Uturn(), new Wildcharge(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Defog(), new Dragonrush() };
		public override int Weight => 80;
		public override int ExpYield => 49;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}