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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Reckless(), new Abilities.Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Soundproof() };
		public override Stats BaseStats => new Stats(95, 110, 95, 40, 95, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
			[5] = new List<Move>() { new Moves.Focusenergy() },
			[10] = new List<Move>() { new Moves.Furyattack() },
			[15] = new List<Move>() { new Moves.Revenge() },
			[20] = new List<Move>() { new Moves.Scaryface() },
			[25] = new List<Move>() { new Moves.Hornattack() },
			[30] = new List<Move>() { new Moves.Reversal() },
			[35] = new List<Move>() { new Moves.Throatchop() },
			[40] = new List<Move>() { new Moves.Headcharge() },
			[45] = new List<Move>() { new Moves.Swordsdance() },
			[50] = new List<Move>() { new Moves.Megahorn() },
			[55] = new List<Move>() { new Moves.Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Ironhead(), new Moves.Lashout(), new Moves.Megahorn(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Uproar(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Belch(), new Moves.Cottonguard(), new Moves.Endeavor(), new Moves.Headbutt(), new Moves.Mudslap(), new Moves.Skullbash(), new Moves.Stomp() };
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