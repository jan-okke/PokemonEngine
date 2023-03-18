using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Falinks : Pokemon
	{
		public override string Name => "Falinks";
		public override List<Ability> AvailableAbilities => new() {new Battlearmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(65, 100, 100, 75, 70, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Protect() },
			[5] = new List<Move>() { new Rocksmash() },
			[10] = new List<Move>() { new Focusenergy() },
			[15] = new List<Move>() { new Headbutt() },
			[20] = new List<Move>() { new Bulkup() },
			[25] = new List<Move>() { new Endure() },
			[30] = new List<Move>() { new Reversal() },
			[35] = new List<Move>() { new Firstimpression() },
			[40] = new List<Move>() { new Noretreat() },
			[45] = new List<Move>() { new Irondefense() },
			[50] = new List<Move>() { new Closecombat() },
			[55] = new List<Move>() { new Megahorn() },
			[60] = new List<Move>() { new Counter() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Beatup(), new Brickbreak(), new Bulkup(), new Closecombat(), new Coaching(), new Endure(), new Facade(), new Falseswipe(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Megahorn(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Screech(), new Sleeptalk(), new Smartstrike(), new Snore(), new Substitute(), new Superpower(), new Swordsdance(), new Throatchop(), new Zenheadbutt() };
		public override int Weight => 620;
		public override int ExpYield => 165;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}