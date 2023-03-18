using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vulpix : Pokemon
	{
		public override string Name => "Vulpix";
		public override List<Ability> AvailableAbilities => new() {new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Drought() };
		public override Stats BaseStats => new Stats(38, 41, 40, 50, 65, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Ember(), new Tailwhip() },
			[4] = new List<Move>() { new Disable() },
			[8] = new List<Move>() { new Quickattack() },
			[12] = new List<Move>() { new Spite() },
			[16] = new List<Move>() { new Incinerate() },
			[20] = new List<Move>() { new Confuseray() },
			[24] = new List<Move>() { new Willowisp() },
			[28] = new List<Move>() { new Extrasensory() },
			[32] = new List<Move>() { new Flamethrower() },
			[36] = new List<Move>() { new Imprison() },
			[40] = new List<Move>() { new Firespin() },
			[44] = new List<Move>() { new Safeguard() },
			[48] = new List<Move>() { new Inferno() },
			[52] = new List<Move>() { new Grudge() },
			[56] = new List<Move>() { new Fireblast() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bodyslam(), new Burningjealousy(), new Darkpulse(), new Dig(), new Doubleteam(), new Encore(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Foulplay(), new Heatwave(), new Hex(), new Hiddenpower(), new Imprison(), new Irontail(), new Mysticalfire(), new Overheat(), new Payback(), new Powerswap(), new Protect(), new Psychup(), new Rest(), new Roar(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Tailslap(), new Weatherball(), new Willowisp(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Babydolleyes(), new Disable(), new Extrasensory(), new Flail(), new Flamecharge(), new Flareblitz(), new Heatwave(), new Hex(), new Howl(), new Hypnosis(), new Memento(), new Powerswap(), new Spite() };
		public override int Weight => 99;
		public override int ExpYield => 60;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}