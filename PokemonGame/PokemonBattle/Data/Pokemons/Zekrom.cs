using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zekrom : Pokemon
	{
		public override string Name => "Zekrom";
		public override List<Ability> AvailableAbilities => new() {new Teravolt() };
		public override Stats BaseStats => new Stats(100, 150, 120, 90, 120, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Dragonbreath(), new Nobleroar(), new Ancientpower(), new Thunderfang() },
			[8] = new List<Move>() { new Slash() },
			[16] = new List<Move>() { new Crunch() },
			[24] = new List<Move>() { new Zenheadbutt() },
			[32] = new List<Move>() { new Dragonclaw() },
			[40] = new List<Move>() { new Thunderbolt() },
			[48] = new List<Move>() { new Fusionbolt() },
			[56] = new List<Move>() { new Hypervoice() },
			[64] = new List<Move>() { new Thunder() },
			[72] = new List<Move>() { new Imprison() },
			[80] = new List<Move>() { new Outrage() },
			[88] = new List<Move>() { new Boltstrike() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodypress(), new Breakingswipe(), new Brutalswing(), new Crunch(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Earthpower(), new Electroball(), new Endure(), new Facade(), new Flashcannon(), new Fling(), new Fly(), new Focusblast(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Imprison(), new Lightscreen(), new Outrage(), new Payback(), new Protect(), new Psychic(), new Raindance(), new Reflect(), new Rest(), new Risingvoltage(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Scaleshot(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Steelwing(), new Stoneedge(), new Substitute(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderpunch(), new Thunderwave(), new Voltswitch(), new Weatherball(), new Wildcharge(), new Zenheadbutt() };
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
}