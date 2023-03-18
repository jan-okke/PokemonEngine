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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Insomnia(), new Abilities.Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Tintedlens() };
		public override Stats BaseStats => new Stats(60, 30, 30, 36, 56, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Peck(), new Moves.Growl() },
			[3] = new List<Move>() { new Moves.Tackle() },
			[6] = new List<Move>() { new Moves.Echoedvoice() },
			[9] = new List<Move>() { new Moves.Confusion() },
			[12] = new List<Move>() { new Moves.Reflect() },
			[15] = new List<Move>() { new Moves.Psychoshift() },
			[18] = new List<Move>() { new Moves.Airslash() },
			[21] = new List<Move>() { new Moves.Extrasensory() },
			[24] = new List<Move>() { new Moves.Takedown() },
			[27] = new List<Move>() { new Moves.Uproar() },
			[30] = new List<Move>() { new Moves.Roost() },
			[33] = new List<Move>() { new Moves.Moonblast() },
			[36] = new List<Move>() { new Moves.Hypnosis() },
			[39] = new List<Move>() { new Moves.Dreameater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hypervoice(), new Moves.Imprison(), new Moves.Nastyplot(), new Moves.Pluck(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Uproar(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Featherdance(), new Moves.Hurricane(), new Moves.Meanlook(), new Moves.Nightshade(), new Moves.Skyattack(), new Moves.Supersonic(), new Moves.Whirlwind(), new Moves.Wingattack() };
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