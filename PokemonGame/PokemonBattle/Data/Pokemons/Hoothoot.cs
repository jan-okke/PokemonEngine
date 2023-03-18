using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hoothoot : Pokemon
	{
		public override string Name => "Hoothoot";
		public override List<Ability> AvailableAbilities => new() {new Insomnia(), new Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Tintedlens() };
		public override Stats BaseStats => new Stats(60, 30, 30, 36, 56, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Growl() },
			[3] = new List<Move>() { new Tackle() },
			[6] = new List<Move>() { new Echoedvoice() },
			[9] = new List<Move>() { new Confusion() },
			[12] = new List<Move>() { new Reflect() },
			[15] = new List<Move>() { new Psychoshift() },
			[18] = new List<Move>() { new Airslash() },
			[21] = new List<Move>() { new Extrasensory() },
			[24] = new List<Move>() { new Takedown() },
			[27] = new List<Move>() { new Uproar() },
			[30] = new List<Move>() { new Roost() },
			[33] = new List<Move>() { new Moonblast() },
			[36] = new List<Move>() { new Hypnosis() },
			[39] = new List<Move>() { new Dreameater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Airslash(), new Amnesia(), new Attract(), new Calmmind(), new Defog(), new Doubleteam(), new Dreameater(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hypervoice(), new Imprison(), new Nastyplot(), new Pluck(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Roost(), new Round(), new Screech(), new Shadowball(), new Sleeptalk(), new Snore(), new Steelwing(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Uproar(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Featherdance(), new Hurricane(), new Meanlook(), new Nightshade(), new Skyattack(), new Supersonic(), new Whirlwind(), new Wingattack() };
		public override int Weight => 212;
		public override int ExpYield => 52;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}