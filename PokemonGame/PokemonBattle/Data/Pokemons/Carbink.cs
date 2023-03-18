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
		public override List<Ability> AvailableAbilities => new() {new Clearbody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sturdy() };
		public override Stats BaseStats => new Stats(50, 50, 150, 50, 50, 150);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden() },
			[5] = new List<Move>() { new Guardsplit() },
			[10] = new List<Move>() { new Smackdown() },
			[15] = new List<Move>() { new Flail() },
			[20] = new List<Move>() { new Ancientpower() },
			[25] = new List<Move>() { new Rockpolish() },
			[30] = new List<Move>() { new Lightscreen() },
			[35] = new List<Move>() { new Rockslide() },
			[40] = new List<Move>() { new Skillswap() },
			[45] = new List<Move>() { new Powergem() },
			[50] = new List<Move>() { new Stealthrock() },
			[55] = new List<Move>() { new Moonblast() },
			[60] = new List<Move>() { new Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Bodypress(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Earthpower(), new Endure(), new Facade(), new Guardswap(), new Gyroball(), new Hail(), new Hiddenpower(), new Irondefense(), new Lightscreen(), new Meteorbeam(), new Mistyexplosion(), new Powergem(), new Protect(), new Psychic(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Skillswap(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Terrainpulse(), new Trickroom(), new Wonderroom() };
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