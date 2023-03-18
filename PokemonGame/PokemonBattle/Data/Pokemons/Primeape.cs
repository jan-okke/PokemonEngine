using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Primeape : Pokemon
	{
		public override string Name => "Primeape";
		public override List<Ability> AvailableAbilities => new() {new Vitalspirit(), new Angerpoint() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(65, 105, 60, 95, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Finalgambit(), new Fling(), new Scratch(), new Lowkick(), new Leer(), new Focusenergy() },
			[5] = new List<Move>() { new Furyswipes() },
			[8] = new List<Move>() { new Mudslap() },
			[12] = new List<Move>() { new Seismictoss() },
			[15] = new List<Move>() { new Retaliate() },
			[19] = new List<Move>() { new Swagger() },
			[22] = new List<Move>() { new Crosschop() },
			[26] = new List<Move>() { new Assurance() },
			[30] = new List<Move>() { new Skullbash() },
			[35] = new List<Move>() { new Thrash() },
			[39] = new List<Move>() { new Closecombat() },
			[44] = new List<Move>() { new Screech() },
			[48] = new List<Move>() { new Stompingtantrum() },
			[53] = new List<Move>() { new Outrage() },
			[57] = new List<Move>() { new Finalgambit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Covet(), new Dig(), new Doubleteam(), new Dualchop(), new Earthquake(), new Endeavor(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Irontail(), new Lowkick(), new Lowsweep(), new Outrage(), new Overheat(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Seedbomb(), new Sleeptalk(), new Smackdown(), new Snore(), new Spite(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Uproar(), new Uturn(), new Workup() };
		public override int Weight => 320;
		public override int ExpYield => 159;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}