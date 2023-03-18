using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Binacle : Pokemon
	{
		public override string Name => "Binacle";
		public override List<Ability> AvailableAbilities => new() {new Toughclaws(), new Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(42, 52, 67, 50, 39, 56);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Mudslap() },
			[4] = new List<Move>() { new Withdraw() },
			[8] = new List<Move>() { new Watergun() },
			[12] = new List<Move>() { new Furycutter() },
			[16] = new List<Move>() { new Furyswipes() },
			[20] = new List<Move>() { new Ancientpower() },
			[24] = new List<Move>() { new Rockpolish() },
			[28] = new List<Move>() { new Slash() },
			[32] = new List<Move>() { new Honeclaws() },
			[36] = new List<Move>() { new Razorshell() },
			[40] = new List<Move>() { new Shellsmash() },
			[44] = new List<Move>() { new Crosschop() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Beatup(), new Blizzard(), new Brickbreak(), new Bulldoze(), new Dig(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irondefense(), new Liquidation(), new Mudshot(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scald(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Surf(), new Swordsdance(), new Taunt(), new Thief(), new Uproar(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Nightslash(), new Sandattack(), new Switcheroo() };
		public override int Weight => 310;
		public override int ExpYield => 61;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}