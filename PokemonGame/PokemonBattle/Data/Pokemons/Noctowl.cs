using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Noctowl : Pokemon
	{
		public override string Name => "Noctowl";
		public override List<Ability> AvailableAbilities => new() {new Insomnia(), new Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Tintedlens() };
		public override Stats BaseStats => new Stats(100, 50, 50, 70, 86, 96);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Skyattack(), new Peck(), new Growl(), new Tackle(), new Echoedvoice() },
			[9] = new List<Move>() { new Confusion() },
			[12] = new List<Move>() { new Reflect() },
			[15] = new List<Move>() { new Psychoshift() },
			[18] = new List<Move>() { new Airslash() },
			[23] = new List<Move>() { new Extrasensory() },
			[28] = new List<Move>() { new Takedown() },
			[33] = new List<Move>() { new Uproar() },
			[38] = new List<Move>() { new Roost() },
			[43] = new List<Move>() { new Moonblast() },
			[48] = new List<Move>() { new Hypnosis() },
			[53] = new List<Move>() { new Dreameater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Airslash(), new Amnesia(), new Attract(), new Calmmind(), new Defog(), new Doubleteam(), new Dreameater(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Futuresight(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Hypervoice(), new Imprison(), new Nastyplot(), new Pluck(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Roost(), new Round(), new Screech(), new Shadowball(), new Sleeptalk(), new Snore(), new Steelwing(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Uproar(), new Workup(), new Zenheadbutt() };
		public override int Weight => 408;
		public override int ExpYield => 158;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}