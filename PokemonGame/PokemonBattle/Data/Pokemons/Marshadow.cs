using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Marshadow : Pokemon
	{
		public override string Name => "Marshadow";
		public override List<Ability> AvailableAbilities => new() {new Technician() };
		public override Stats BaseStats => new Stats(90, 125, 80, 125, 90, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thunderpunch(), new Firepunch(), new Icepunch(), new Copycat(), new Shadowsneak(), new Feint(), new Counter() },
			[9] = new List<Move>() { new Roleplay() },
			[18] = new List<Move>() { new Shadowpunch() },
			[27] = new List<Move>() { new Forcepalm() },
			[36] = new List<Move>() { new Assurance() },
			[45] = new List<Move>() { new Suckerpunch() },
			[54] = new List<Move>() { new Drainpunch() },
			[63] = new List<Move>() { new Psychup() },
			[72] = new List<Move>() { new Spectralthief() },
			[81] = new List<Move>() { new Laserfocus() },
			[90] = new List<Move>() { new Endeavor() },
			[99] = new List<Move>() { new Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Assurance(), new Aurasphere(), new Blazekick(), new Bounce(), new Brickbreak(), new Bulkup(), new Calmmind(), new Closecombat(), new Coaching(), new Drainpunch(), new Endure(), new Facade(), new Falseswipe(), new Firepunch(), new Fling(), new Focusblast(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Ironhead(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Outrage(), new Payback(), new Phantomforce(), new Poisonjab(), new Poltergeist(), new Protect(), new Rest(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Shadowball(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Snore(), new Stoneedge(), new Substitute(), new Superpower(), new Swift(), new Thief(), new Throatchop(), new Thunderpunch(), new Willowisp(), new Workup(), new Zenheadbutt() };
		public override int Weight => 222;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}