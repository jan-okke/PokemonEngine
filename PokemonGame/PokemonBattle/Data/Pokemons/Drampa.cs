using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drampa : Pokemon
	{
		public override string Name => "Drampa";
		public override List<Ability> AvailableAbilities => new() {new Berserk(), new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cloudnine() };
		public override Stats BaseStats => new Stats(78, 60, 85, 36, 135, 91);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Playnice(), new Echoedvoice() },
			[5] = new List<Move>() { new Twister() },
			[10] = new List<Move>() { new Protect() },
			[15] = new List<Move>() { new Glare() },
			[20] = new List<Move>() { new Safeguard() },
			[25] = new List<Move>() { new Dragonbreath() },
			[30] = new List<Move>() { new Extrasensory() },
			[35] = new List<Move>() { new Dragonpulse() },
			[40] = new List<Move>() { new Lightscreen() },
			[45] = new List<Move>() { new Fly() },
			[50] = new List<Move>() { new Hypervoice() },
			[55] = new List<Move>() { new Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Breakingswipe(), new Bulldoze(), new Calmmind(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Flamethrower(), new Fling(), new Fly(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Lashout(), new Lightscreen(), new Outrage(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Safeguard(), new Scaleshot(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Steelwing(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uproar(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Dragonrush(), new Mist(), new Tickle() };
		public override int Weight => 1850;
		public override int ExpYield => 170;
		public override int CatchRate => 70;
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
}