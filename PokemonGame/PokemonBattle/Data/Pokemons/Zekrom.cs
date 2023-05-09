using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Zekrom : Pokemon
{
	public override string Name => "Zekrom";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Teravolt() };
	public override Stats BaseStats => new Stats(100, 150, 120, 120, 100, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Dragonbreath(), new Moves.Nobleroar(), new Moves.Ancientpower(), new Moves.Thunderfang() },
		[8] = new List<Move>() { new Moves.Slash() },
		[16] = new List<Move>() { new Moves.Crunch() },
		[24] = new List<Move>() { new Moves.Zenheadbutt() },
		[32] = new List<Move>() { new Moves.Dragonclaw() },
		[40] = new List<Move>() { new Moves.Thunderbolt() },
		[48] = new List<Move>() { new Moves.Fusionbolt() },
		[56] = new List<Move>() { new Moves.Hypervoice() },
		[64] = new List<Move>() { new Moves.Thunder() },
		[72] = new List<Move>() { new Moves.Imprison() },
		[80] = new List<Move>() { new Moves.Outrage() },
		[88] = new List<Move>() { new Moves.Boltstrike() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodypress(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Crunch(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaleshot(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Weatherball(), new Moves.Wildcharge(), new Moves.Zenheadbutt() };
	public override int Weight => 3450;
	public override int ExpYield => 340;
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