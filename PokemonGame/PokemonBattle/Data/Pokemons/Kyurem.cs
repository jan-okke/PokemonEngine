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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
		public override Stats BaseStats => new Stats(125, 130, 90, 130, 90, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Dragonbreath(), new Moves.Nobleroar(), new Moves.Ancientpower(), new Moves.Freezedry() },
			[8] = new List<Move>() { new Moves.Slash() },
			[16] = new List<Move>() { new Moves.Endeavor() },
			[24] = new List<Move>() { new Moves.Dragonpulse() },
			[32] = new List<Move>() { new Moves.Icebeam() },
			[40] = new List<Move>() { new Moves.Hypervoice() },
			[48] = new List<Move>() { new Moves.Scaryface() },
			[56] = new List<Move>() { new Moves.Blizzard() },
			[64] = new List<Move>() { new Moves.Imprison() },
			[72] = new List<Move>() { new Moves.Outrage() },
			[80] = new List<Move>() { new Moves.Glaciate() },
			[88] = new List<Move>() { new Moves.Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Weatherball(), new Moves.Zenheadbutt() };
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