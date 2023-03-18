using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bouffalant : Pokemon
	{
		public override string Name => "Bouffalant";
		public override List<Ability> AvailableAbilities => new() {new Reckless(), new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Soundproof() };
		public override Stats BaseStats => new Stats(95, 110, 95, 55, 40, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[5] = new List<Move>() { new Focusenergy() },
			[10] = new List<Move>() { new Furyattack() },
			[15] = new List<Move>() { new Revenge() },
			[20] = new List<Move>() { new Scaryface() },
			[25] = new List<Move>() { new Hornattack() },
			[30] = new List<Move>() { new Reversal() },
			[35] = new List<Move>() { new Throatchop() },
			[40] = new List<Move>() { new Headcharge() },
			[45] = new List<Move>() { new Swordsdance() },
			[50] = new List<Move>() { new Megahorn() },
			[55] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Assurance(), new Attract(), new Bodyslam(), new Bulldoze(), new Closecombat(), new Earthquake(), new Endure(), new Facade(), new Focusenergy(), new Gigaimpact(), new Hiddenpower(), new Highhorsepower(), new Ironhead(), new Lashout(), new Megahorn(), new Mudshot(), new Outrage(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Smartstrike(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swordsdance(), new Taunt(), new Throatchop(), new Uproar(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Belch(), new Cottonguard(), new Endeavor(), new Headbutt(), new Mudslap(), new Skullbash(), new Stomp() };
		public override int Weight => 945;
		public override int ExpYield => 172;
		public override int CatchRate => 45;
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