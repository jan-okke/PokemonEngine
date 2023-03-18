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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Toughclaws(), new Abilities.Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pickpocket() };
		public override Stats BaseStats => new Stats(72, 105, 115, 54, 86, 68);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Skullbash(), new Moves.Scratch(), new Moves.Mudslap(), new Moves.Withdraw(), new Moves.Watergun() },
			[12] = new List<Move>() { new Moves.Furycutter() },
			[16] = new List<Move>() { new Moves.Furyswipes() },
			[20] = new List<Move>() { new Moves.Ancientpower() },
			[24] = new List<Move>() { new Moves.Rockpolish() },
			[28] = new List<Move>() { new Moves.Slash() },
			[32] = new List<Move>() { new Moves.Honeclaws() },
			[36] = new List<Move>() { new Moves.Razorshell() },
			[42] = new List<Move>() { new Moves.Shellsmash() },
			[48] = new List<Move>() { new Moves.Crosschop() },
			[54] = new List<Move>() { new Moves.Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Dive(), new Moves.Dragonclaw(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Liquidation(), new Moves.Lowkick(), new Moves.Meteorbeam(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uproar(), new Moves.Whirlpool(), new Moves.Xscissor() };
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