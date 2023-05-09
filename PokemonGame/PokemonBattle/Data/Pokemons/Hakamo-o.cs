using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Hakamoo : Pokemon
{
	public override string Name => "Hakamo-o";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Bulletproof(), new Abilities.Soundproof() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
	public override Stats BaseStats => new Stats(55, 75, 90, 65, 70, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Autotomize(), new Moves.Tackle(), new Moves.Leer(), new Moves.Protect(), new Moves.Dragontail() },
		[12] = new List<Move>() { new Moves.Scaryface() },
		[16] = new List<Move>() { new Moves.Headbutt() },
		[20] = new List<Move>() { new Moves.Workup() },
		[24] = new List<Move>() { new Moves.Screech() },
		[28] = new List<Move>() { new Moves.Irondefense() },
		[32] = new List<Move>() { new Moves.Dragonclaw() },
		[38] = new List<Move>() { new Moves.Nobleroar() },
		[44] = new List<Move>() { new Moves.Dragondance() },
		[50] = new List<Move>() { new Moves.Outrage() },
		[56] = new List<Move>() { new Moves.Closecombat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Workup(), new Moves.Xscissor() };
	public override int Weight => 470;
	public override int ExpYield => 147;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}