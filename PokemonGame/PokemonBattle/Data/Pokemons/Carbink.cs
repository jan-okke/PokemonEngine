using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Carbink : Pokemon
	{
		public override string Name => "Carbink";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Clearbody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sturdy() };
		public override Stats BaseStats => new Stats(50, 50, 150, 50, 150, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden() },
			[5] = new List<Move>() { new Moves.Guardsplit() },
			[10] = new List<Move>() { new Moves.Smackdown() },
			[15] = new List<Move>() { new Moves.Flail() },
			[20] = new List<Move>() { new Moves.Ancientpower() },
			[25] = new List<Move>() { new Moves.Rockpolish() },
			[30] = new List<Move>() { new Moves.Lightscreen() },
			[35] = new List<Move>() { new Moves.Rockslide() },
			[40] = new List<Move>() { new Moves.Skillswap() },
			[45] = new List<Move>() { new Moves.Powergem() },
			[50] = new List<Move>() { new Moves.Stealthrock() },
			[55] = new List<Move>() { new Moves.Moonblast() },
			[60] = new List<Move>() { new Moves.Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Bodypress(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Mistyexplosion(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychic(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Terrainpulse(), new Moves.Trickroom(), new Moves.Wonderroom() };
		public override int Weight => 57;
		public override int ExpYield => 100;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}