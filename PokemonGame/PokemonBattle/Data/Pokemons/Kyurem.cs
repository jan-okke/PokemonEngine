using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kyurem : Pokemon
	{
		public override string Name => "Kyurem";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override Stats BaseStats => new Stats(125, 130, 90, 95, 130, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Dragonbreath(), new Nobleroar(), new Ancientpower(), new Freezedry() },
			[8] = new List<Move>() { new Slash() },
			[16] = new List<Move>() { new Endeavor() },
			[24] = new List<Move>() { new Dragonpulse() },
			[32] = new List<Move>() { new Icebeam() },
			[40] = new List<Move>() { new Hypervoice() },
			[48] = new List<Move>() { new Scaryface() },
			[56] = new List<Move>() { new Blizzard() },
			[64] = new List<Move>() { new Imprison() },
			[72] = new List<Move>() { new Outrage() },
			[80] = new List<Move>() { new Glaciate() },
			[88] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Blizzard(), new Bodypress(), new Breakingswipe(), new Brutalswing(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Earthpower(), new Endure(), new Facade(), new Flashcannon(), new Fling(), new Fly(), new Focusblast(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Iciclespear(), new Icywind(), new Imprison(), new Ironhead(), new Lightscreen(), new Outrage(), new Payback(), new Protect(), new Psychic(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Scaleshot(), new Scaryface(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Steelwing(), new Stoneedge(), new Substitute(), new Sunnyday(), new Swift(), new Weatherball(), new Zenheadbutt() };
		public override int Weight => 3250;
		public override int ExpYield => 330;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}