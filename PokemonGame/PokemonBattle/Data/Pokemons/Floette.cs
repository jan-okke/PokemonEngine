using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Floette : Pokemon
	{
		public override string Name => "Floette";
		public override List<Ability> AvailableAbilities => new() {new Flowerveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Symbiosis() };
		public override Stats BaseStats => new Stats(54, 45, 47, 75, 98, 52);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Vinewhip(), new Fairywind() },
			[6] = new List<Move>() { new Fairywind() },
			[10] = new List<Move>() { new Luckychant() },
			[15] = new List<Move>() { new Razorleaf() },
			[20] = new List<Move>() { new Wish() },
			[25] = new List<Move>() { new Magicalleaf() },
			[27] = new List<Move>() { new Grassyterrain() },
			[33] = new List<Move>() { new Petalblizzard() },
			[38] = new List<Move>() { new Aromatherapy() },
			[43] = new List<Move>() { new Mistyterrain() },
			[46] = new List<Move>() { new Moonblast() },
			[51] = new List<Move>() { new Petaldance() },
			[58] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Allyswitch(), new Attract(), new Calmmind(), new Confide(), new Covet(), new Dazzlinggleam(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Grassknot(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Magiccoat(), new Naturepower(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Toxic(), new Worryseed() };
		public override int Weight => 9;
		public override int ExpYield => 130;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}