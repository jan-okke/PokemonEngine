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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Flowerveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Symbiosis() };
		public override Stats BaseStats => new Stats(78, 65, 68, 112, 154, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Disarmingvoice(), new Moves.Luckychant(), new Moves.Wish(), new Moves.Magicalleaf(), new Moves.Flowershield(), new Moves.Grassknot(), new Moves.Grassyterrain(), new Moves.Petalblizzard(), new Moves.Mistyterrain(), new Moves.Moonblast(), new Moves.Petaldance(), new Moves.Aromatherapy() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Covet(), new Moves.Dazzlinggleam(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Healbell(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Toxic(), new Moves.Worryseed() };
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