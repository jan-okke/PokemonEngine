using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Yveltal : Pokemon
	{
		public override string Name => "Yveltal";
		public override List<Ability> AvailableAbilities => new() {new Darkaura() };
		public override Stats BaseStats => new Stats(126, 131, 95, 131, 98, 99);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Doubleteam() },
			[5] = new List<Move>() { new Taunt() },
			[10] = new List<Move>() { new Snarl() },
			[15] = new List<Move>() { new Disable() },
			[20] = new List<Move>() { new Suckerpunch() },
			[25] = new List<Move>() { new Tailwind() },
			[30] = new List<Move>() { new Roost() },
			[35] = new List<Move>() { new Airslash() },
			[40] = new List<Move>() { new Darkpulse() },
			[45] = new List<Move>() { new Psychic() },
			[50] = new List<Move>() { new Oblivionwing() },
			[55] = new List<Move>() { new Phantomforce() },
			[60] = new List<Move>() { new Foulplay() },
			[65] = new List<Move>() { new Dragonrush() },
			[70] = new List<Move>() { new Hurricane() },
			[75] = new List<Move>() { new Focusblast() },
			[80] = new List<Move>() { new Skyattack() },
			[85] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Airslash(), new Bodyslam(), new Darkpulse(), new Dragonclaw(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Focusblast(), new Foulplay(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Hypervoice(), new Lashout(), new Payback(), new Phantomforce(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Thief(), new Uturn(), new Zenheadbutt() };
		public override int Weight => 2030;
		public override int ExpYield => 340;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}