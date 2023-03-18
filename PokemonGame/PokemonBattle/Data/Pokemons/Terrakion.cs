using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Terrakion : Pokemon
	{
		public override string Name => "Terrakion";
		public override List<Ability> AvailableAbilities => new() {new Justified() };
		public override Stats BaseStats => new Stats(91, 129, 90, 72, 90, 108);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Leer(), new Helpinghand(), new Workup() },
			[7] = new List<Move>() { new Smackdown() },
			[14] = new List<Move>() { new Quickguard() },
			[21] = new List<Move>() { new Doublekick() },
			[28] = new List<Move>() { new Retaliate() },
			[35] = new List<Move>() { new Rockslide() },
			[42] = new List<Move>() { new Takedown() },
			[49] = new List<Move>() { new Sacredsword() },
			[56] = new List<Move>() { new Swordsdance() },
			[63] = new List<Move>() { new Stoneedge() },
			[70] = new List<Move>() { new Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Brickbreak(), new Bulldoze(), new Calmmind(), new Closecombat(), new Coaching(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Focusblast(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Megahorn(), new Poisonjab(), new Protect(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scaryface(), new Sleeptalk(), new Smartstrike(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Swift(), new Swordsdance(), new Taunt(), new Workup(), new Xscissor(), new Zenheadbutt() };
		public override int Weight => 2600;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}