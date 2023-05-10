using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Reshiram : Pokemon
{
	public override string Name => "Reshiram";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Turboblaze() };
	public override Stats BaseStats => new Stats(100, 120, 100, 150, 120, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Dragonbreath(), new Moves.Nobleroar(), new Moves.Ancientpower(), new Moves.Firefang() },
		[8] = new List<Move>() { new Moves.Slash() },
		[16] = new List<Move>() { new Moves.Crunch() },
		[24] = new List<Move>() { new Moves.Extrasensory() },
		[32] = new List<Move>() { new Moves.Dragonpulse() },
		[40] = new List<Move>() { new Moves.Flamethrower() },
		[48] = new List<Move>() { new Moves.Fusionflare() },
		[56] = new List<Move>() { new Moves.Hypervoice() },
		[64] = new List<Move>() { new Moves.Fireblast() },
		[72] = new List<Move>() { new Moves.Imprison() },
		[80] = new List<Move>() { new Moves.Outrage() },
		[88] = new List<Move>() { new Moves.Blueflare() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodypress(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Crunch(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Mysticalfire(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaleshot(), new Moves.Scorchingsands(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Weatherball(), new Moves.Willowisp(), new Moves.Zenheadbutt() };
	public override int Weight => 3300;
	public override int ExpYield => 340;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}