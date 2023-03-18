using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Greninja : Pokemon
	{
		public override string Name => "Greninja";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Protean() };
		public override Stats BaseStats => new Stats(72, 95, 67, 122, 103, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Watershuriken() },
			[1] = new List<Move>() { new Watershuriken(), new Nightslash(), new Haze(), new Roleplay(), new Matblock(), new Pound(), new Growl(), new Bubble(), new Quickattack() },
			[5] = new List<Move>() { new Bubble() },
			[8] = new List<Move>() { new Quickattack() },
			[10] = new List<Move>() { new Lick() },
			[14] = new List<Move>() { new Waterpulse() },
			[19] = new List<Move>() { new Smokescreen() },
			[23] = new List<Move>() { new Shadowsneak() },
			[28] = new List<Move>() { new Spikes() },
			[33] = new List<Move>() { new Feintattack() },
			[42] = new List<Move>() { new Substitute() },
			[49] = new List<Move>() { new Extrasensory() },
			[56] = new List<Move>() { new Doubleteam() },
			[68] = new List<Move>() { new Hydropump() },
			[70] = new List<Move>() { new Haze() },
			[77] = new List<Move>() { new Nightslash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Blizzard(), new Bounce(), new Brutalswing(), new Confide(), new Cut(), new Darkpulse(), new Dive(), new Doubleteam(), new Echoedvoice(), new Facade(), new Fling(), new Frustration(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Hiddenpower(), new Hydrocannon(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Lowkick(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Scald(), new Sleeptalk(), new Smackdown(), new Snatch(), new Snore(), new Spite(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Taunt(), new Thief(), new Toxic(), new Uturn(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override int Weight => 400;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}