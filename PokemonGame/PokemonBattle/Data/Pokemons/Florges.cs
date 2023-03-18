using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Florges : Pokemon
	{
		public override string Name => "Florges";
		public override List<Ability> AvailableAbilities => new() {new Flowerveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Symbiosis() };
		public override Stats BaseStats => new Stats(78, 65, 68, 112, 154, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Disarmingvoice(), new Luckychant(), new Wish(), new Magicalleaf(), new Flowershield(), new Grassknot(), new Grassyterrain(), new Petalblizzard(), new Mistyterrain(), new Moonblast(), new Petaldance(), new Aromatherapy() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Allyswitch(), new Attract(), new Calmmind(), new Confide(), new Covet(), new Dazzlinggleam(), new Defog(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Magiccoat(), new Naturepower(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Toxic(), new Worryseed() };
		public override int Weight => 100;
		public override int ExpYield => 276;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}