using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Flabébé : Pokemon
	{
		public override string Name => "Flabébé";
		public override List<Ability> AvailableAbilities => new() {new Flowerveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Symbiosis() };
		public override Stats BaseStats => new Stats(44, 38, 39, 61, 79, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Vinewhip() },
			[6] = new List<Move>() { new Fairywind() },
			[10] = new List<Move>() { new Luckychant() },
			[15] = new List<Move>() { new Razorleaf() },
			[20] = new List<Move>() { new Wish() },
			[22] = new List<Move>() { new Magicalleaf() },
			[24] = new List<Move>() { new Grassyterrain() },
			[28] = new List<Move>() { new Petalblizzard() },
			[33] = new List<Move>() { new Aromatherapy() },
			[37] = new List<Move>() { new Mistyterrain() },
			[41] = new List<Move>() { new Moonblast() },
			[45] = new List<Move>() { new Petaldance() },
			[48] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Allyswitch(), new Attract(), new Calmmind(), new Confide(), new Covet(), new Dazzlinggleam(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Grassknot(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Magiccoat(), new Naturepower(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Toxic(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Camouflage(), new Captivate(), new Copycat(), new Tearfullook() };
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