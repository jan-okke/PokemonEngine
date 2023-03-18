using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Reshiram : Pokemon
	{
		public override string Name => "Reshiram";
		public override List<Ability> AvailableAbilities => new() {new Turboblaze() };
		public override Stats BaseStats => new Stats(100, 120, 100, 150, 120, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Dragonbreath(), new Nobleroar(), new Ancientpower(), new Firefang() },
			[8] = new List<Move>() { new Slash() },
			[16] = new List<Move>() { new Crunch() },
			[24] = new List<Move>() { new Extrasensory() },
			[32] = new List<Move>() { new Dragonpulse() },
			[40] = new List<Move>() { new Flamethrower() },
			[48] = new List<Move>() { new Fusionflare() },
			[56] = new List<Move>() { new Hypervoice() },
			[64] = new List<Move>() { new Fireblast() },
			[72] = new List<Move>() { new Imprison() },
			[80] = new List<Move>() { new Outrage() },
			[88] = new List<Move>() { new Blueflare() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodypress(), new Breakingswipe(), new Brutalswing(), new Crunch(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Earthpower(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Flamethrower(), new Flareblitz(), new Fling(), new Fly(), new Focusblast(), new Gigaimpact(), new Heatcrash(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Imprison(), new Lightscreen(), new Mysticalfire(), new Outrage(), new Overheat(), new Payback(), new Protect(), new Psychic(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Scaleshot(), new Scorchingsands(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Stoneedge(), new Substitute(), new Sunnyday(), new Swift(), new Weatherball(), new Willowisp(), new Zenheadbutt() };
		public override int Weight => 3300;
		public override int ExpYield => 340;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}