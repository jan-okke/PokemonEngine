using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Drampa : Pokemon
{
	public override string Name => "Drampa";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Berserk(), new Abilities.Sapsipper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cloudnine() };
	public override Stats BaseStats => new Stats(78, 60, 85, 135, 91, 36);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Playnice(), new Moves.Echoedvoice() },
		[5] = new List<Move>() { new Moves.Twister() },
		[10] = new List<Move>() { new Moves.Protect() },
		[15] = new List<Move>() { new Moves.Glare() },
		[20] = new List<Move>() { new Moves.Safeguard() },
		[25] = new List<Move>() { new Moves.Dragonbreath() },
		[30] = new List<Move>() { new Moves.Extrasensory() },
		[35] = new List<Move>() { new Moves.Dragonpulse() },
		[40] = new List<Move>() { new Moves.Lightscreen() },
		[45] = new List<Move>() { new Moves.Fly() },
		[50] = new List<Move>() { new Moves.Hypervoice() },
		[55] = new List<Move>() { new Moves.Outrage() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Breakingswipe(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Lashout(), new Moves.Lightscreen(), new Moves.Outrage(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaleshot(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Dragonrush(), new Moves.Mist(), new Moves.Tickle() };
	public override int Weight => 1850;
	public override int ExpYield => 170;
	public override int CatchRate => 70;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}