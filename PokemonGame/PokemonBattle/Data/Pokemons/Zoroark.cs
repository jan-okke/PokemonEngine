using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Zoroark : Pokemon
{
	public override string Name => "Zoroark";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Illusion() };
	public override Stats BaseStats => new Stats(60, 105, 60, 120, 60, 105);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Nightslash() },
		[1] = new List<Move>() { new Moves.Nightslash(), new Moves.Uturn(), new Moves.Scratch(), new Moves.Leer(), new Moves.Torment(), new Moves.Honeclaws() },
		[12] = new List<Move>() { new Moves.Furyswipes() },
		[16] = new List<Move>() { new Moves.Scaryface() },
		[20] = new List<Move>() { new Moves.Taunt() },
		[24] = new List<Move>() { new Moves.Knockoff() },
		[28] = new List<Move>() { new Moves.Faketears() },
		[34] = new List<Move>() { new Moves.Agility() },
		[40] = new List<Move>() { new Moves.Imprison() },
		[46] = new List<Move>() { new Moves.Nightdaze() },
		[52] = new List<Move>() { new Moves.Nastyplot() },
		[58] = new List<Move>() { new Moves.Foulplay() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bounce(), new Moves.Burningjealousy(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Imprison(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Trick(), new Moves.Uproar(), new Moves.Uturn() };
	public override int Weight => 811;
	public override int ExpYield => 179;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}