using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Toucannon : Pokemon
	{
		public override string Name => "Toucannon";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Skilllink() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
		public override Stats BaseStats => new Stats(80, 120, 75, 75, 75, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Beakblast() },
			[1] = new List<Move>() { new Moves.Beakblast(), new Moves.Rockblast(), new Moves.Peck(), new Moves.Growl(), new Moves.Echoedvoice(), new Moves.Rocksmash() },
			[3] = new List<Move>() { new Moves.Growl() },
			[7] = new List<Move>() { new Moves.Echoedvoice() },
			[9] = new List<Move>() { new Moves.Rocksmash() },
			[13] = new List<Move>() { new Moves.Supersonic() },
			[16] = new List<Move>() { new Moves.Pluck() },
			[21] = new List<Move>() { new Moves.Roost() },
			[24] = new List<Move>() { new Moves.Furyattack() },
			[28] = new List<Move>() { new Moves.Beakblast() },
			[30] = new List<Move>() { new Moves.Screech() },
			[34] = new List<Move>() { new Moves.Drillpeck() },
			[40] = new List<Move>() { new Moves.Bulletseed() },
			[44] = new List<Move>() { new Moves.Featherdance() },
			[50] = new List<Move>() { new Moves.Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Flamecharge(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Frustration(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Knockoff(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
		public override int Weight => 260;
		public override int ExpYield => 243;
		public override int CatchRate => 45;
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