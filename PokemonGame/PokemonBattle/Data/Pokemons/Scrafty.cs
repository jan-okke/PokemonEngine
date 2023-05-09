using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Scrafty : Pokemon
{
	public override string Name => "Scrafty";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shedskin(), new Abilities.Moxie() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Intimidate() };
	public override Stats BaseStats => new Stats(65, 90, 115, 45, 115, 58);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Lowkick(), new Moves.Leer(), new Moves.Payback(), new Moves.Headbutt() },
		[12] = new List<Move>() { new Moves.Sandattack() },
		[16] = new List<Move>() { new Moves.Facade() },
		[20] = new List<Move>() { new Moves.Protect() },
		[24] = new List<Move>() { new Moves.Beatup() },
		[28] = new List<Move>() { new Moves.Scaryface() },
		[32] = new List<Move>() { new Moves.Brickbreak() },
		[36] = new List<Move>() { new Moves.Swagger() },
		[42] = new List<Move>() { new Moves.Crunch() },
		[48] = new List<Move>() { new Moves.Highjumpkick() },
		[54] = new List<Move>() { new Moves.Focuspunch() },
		[60] = new List<Move>() { new Moves.Headsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 300;
	public override int ExpYield => 171;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}