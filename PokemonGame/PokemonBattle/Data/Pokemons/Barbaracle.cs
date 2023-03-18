using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Barbaracle : Pokemon
	{
		public override string Name => "Barbaracle";
		public override List<Ability> AvailableAbilities => new() {new Toughclaws(), new Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(72, 105, 115, 68, 54, 86);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Skullbash(), new Scratch(), new Mudslap(), new Withdraw(), new Watergun() },
			[12] = new List<Move>() { new Furycutter() },
			[16] = new List<Move>() { new Furyswipes() },
			[20] = new List<Move>() { new Ancientpower() },
			[24] = new List<Move>() { new Rockpolish() },
			[28] = new List<Move>() { new Slash() },
			[32] = new List<Move>() { new Honeclaws() },
			[36] = new List<Move>() { new Razorshell() },
			[42] = new List<Move>() { new Shellsmash() },
			[48] = new List<Move>() { new Crosschop() },
			[54] = new List<Move>() { new Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Beatup(), new Blizzard(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Dig(), new Dive(), new Dragonclaw(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Liquidation(), new Lowkick(), new Meteorbeam(), new Muddywater(), new Mudshot(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scald(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Superpower(), new Surf(), new Swordsdance(), new Taunt(), new Thief(), new Uproar(), new Whirlpool(), new Xscissor() };
		public override int Weight => 960;
		public override int ExpYield => 175;
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