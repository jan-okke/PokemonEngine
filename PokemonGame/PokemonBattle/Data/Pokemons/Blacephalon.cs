using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Blacephalon : Pokemon
	{
		public override string Name => "Blacephalon";
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(53, 127, 53, 151, 79, 107);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Firespin() },
			[5] = new List<Move>() { new Lightscreen() },
			[10] = new List<Move>() { new Ember() },
			[15] = new List<Move>() { new Nightshade() },
			[20] = new List<Move>() { new Confuseray() },
			[25] = new List<Move>() { new Magiccoat() },
			[30] = new List<Move>() { new Incinerate() },
			[35] = new List<Move>() { new Hypnosis() },
			[40] = new List<Move>() { new Mysticalfire() },
			[45] = new List<Move>() { new Shadowball() },
			[50] = new List<Move>() { new Calmmind() },
			[55] = new List<Move>() { new Willowisp() },
			[60] = new List<Move>() { new Trick() },
			[65] = new List<Move>() { new Fireblast() },
			[70] = new List<Move>() { new Mindblown() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Calmmind(), new Darkpulse(), new Encore(), new Endure(), new Expandingforce(), new Facade(), new Fireblast(), new Firepunch(), new Firespin(), new Flamethrower(), new Fling(), new Foulplay(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Mysticalfire(), new Overheat(), new Payback(), new Protect(), new Psychic(), new Psyshock(), new Rest(), new Rockblast(), new Round(), new Selfdestruct(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Taunt(), new Thief(), new Trick(), new Uproar(), new Willowisp(), new Zenheadbutt() };
		public override int Weight => 130;
		public override int ExpYield => 285;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}