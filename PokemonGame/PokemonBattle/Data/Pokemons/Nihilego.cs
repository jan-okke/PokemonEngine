using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nihilego : Pokemon
	{
		public override string Name => "Nihilego";
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(109, 53, 47, 103, 127, 131);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wrap(), new Pound() },
			[5] = new List<Move>() { new Acid() },
			[10] = new List<Move>() { new Tickle() },
			[15] = new List<Move>() { new Acidspray() },
			[20] = new List<Move>() { new Clearsmog() },
			[25] = new List<Move>() { new Powersplit(), new Guardsplit() },
			[30] = new List<Move>() { new Venoshock() },
			[35] = new List<Move>() { new Headbutt() },
			[40] = new List<Move>() { new Toxicspikes() },
			[45] = new List<Move>() { new Venomdrench() },
			[50] = new List<Move>() { new Powergem() },
			[55] = new List<Move>() { new Stealthrock() },
			[60] = new List<Move>() { new Mirrorcoat() },
			[65] = new List<Move>() { new Wonderroom() },
			[70] = new List<Move>() { new Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Bodyslam(), new Brutalswing(), new Corrosivegas(), new Crosspoison(), new Dazzlinggleam(), new Endure(), new Facade(), new Foulplay(), new Grassknot(), new Gunkshot(), new Hex(), new Hiddenpower(), new Ironhead(), new Lightscreen(), new Meteorbeam(), new Poisonjab(), new Powergem(), new Protect(), new Psychic(), new Psyshock(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Substitute(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Toxicspikes(), new Trickroom(), new Venomdrench(), new Venoshock(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 555;
		public override int ExpYield => 285;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}