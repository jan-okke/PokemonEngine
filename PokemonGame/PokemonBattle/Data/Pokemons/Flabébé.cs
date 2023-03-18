using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Flabebe : Pokemon
	{
		public override string Name => "Flabébé";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Flowerveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Symbiosis() };
		public override Stats BaseStats => new Stats(44, 38, 39, 61, 79, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Vinewhip() },
			[6] = new List<Move>() { new Moves.Fairywind() },
			[10] = new List<Move>() { new Moves.Luckychant() },
			[15] = new List<Move>() { new Moves.Razorleaf() },
			[20] = new List<Move>() { new Moves.Wish() },
			[22] = new List<Move>() { new Moves.Magicalleaf() },
			[24] = new List<Move>() { new Moves.Grassyterrain() },
			[28] = new List<Move>() { new Moves.Petalblizzard() },
			[33] = new List<Move>() { new Moves.Aromatherapy() },
			[37] = new List<Move>() { new Moves.Mistyterrain() },
			[41] = new List<Move>() { new Moves.Moonblast() },
			[45] = new List<Move>() { new Moves.Petaldance() },
			[48] = new List<Move>() { new Moves.Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Covet(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Healbell(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Magiccoat(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Toxic(), new Moves.Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Camouflage(), new Moves.Captivate(), new Moves.Copycat(), new Moves.Tearfullook() };
		public override int Weight => 1;
		public override int ExpYield => 61;
		public override int CatchRate => 225;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}