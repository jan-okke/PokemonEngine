using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Golisopod : Pokemon
{
	public override string Name => "Golisopod";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Emergencyexit() };
	public override Stats BaseStats => new Stats(75, 125, 140, 60, 90, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Firstimpression() },
		[1] = new List<Move>() { new Moves.Firstimpression(), new Moves.Strugglebug(), new Moves.Sandattack(), new Moves.Defensecurl(), new Moves.Spite() },
		[4] = new List<Move>() { new Moves.Rocksmash() },
		[8] = new List<Move>() { new Moves.Furycutter() },
		[12] = new List<Move>() { new Moves.Mudshot() },
		[16] = new List<Move>() { new Moves.Bugbite() },
		[20] = new List<Move>() { new Moves.Irondefense() },
		[24] = new List<Move>() { new Moves.Suckerpunch() },
		[28] = new List<Move>() { new Moves.Slash() },
		[32] = new List<Move>() { new Moves.Razorshell() },
		[36] = new List<Move>() { new Moves.Pinmissile() },
		[40] = new List<Move>() { new Moves.Swordsdance() },
		[44] = new List<Move>() { new Moves.Liquidation() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Bugbuzz(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Darkpulse(), new Moves.Dive(), new Moves.Drillrun(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Leechlife(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snarl(), new Moves.Snore(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Venoshock(), new Moves.Waterfall(), new Moves.Xscissor() };
	public override int Weight => 1080;
	public override int ExpYield => 186;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}