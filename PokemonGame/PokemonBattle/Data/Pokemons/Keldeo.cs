using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Keldeo : Pokemon
	{
		public override string Name => "Keldeo";
		public override List<Ability> AvailableAbilities => new() {new Justified() };
		public override Stats BaseStats => new Stats(91, 72, 90, 129, 90, 108);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Secretsword(), new Aquajet(), new Leer(), new Helpinghand(), new Workup() },
			[7] = new List<Move>() { new Bubblebeam() },
			[14] = new List<Move>() { new Quickguard() },
			[21] = new List<Move>() { new Doublekick() },
			[28] = new List<Move>() { new Retaliate() },
			[35] = new List<Move>() { new Aquatail() },
			[42] = new List<Move>() { new Takedown() },
			[49] = new List<Move>() { new Sacredsword() },
			[56] = new List<Move>() { new Swordsdance() },
			[63] = new List<Move>() { new Hydropump() },
			[70] = new List<Move>() { new Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Aurasphere(), new Bounce(), new Brickbreak(), new Calmmind(), new Closecombat(), new Coaching(), new Endure(), new Facade(), new Falseswipe(), new Flipturn(), new Focusblast(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icywind(), new Liquidation(), new Lowkick(), new Megahorn(), new Muddywater(), new Poisonjab(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Round(), new Safeguard(), new Scald(), new Sleeptalk(), new Smartstrike(), new Snore(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swift(), new Swordsdance(), new Taunt(), new Workup(), new Xscissor() };
		public override int Weight => 485;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
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