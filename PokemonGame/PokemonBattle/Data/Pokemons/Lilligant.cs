using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lilligant : Pokemon
	{
		public override string Name => "Lilligant";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Owntempo() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Leafguard() };
		public override Stats BaseStats => new Stats(70, 60, 75, 110, 75, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Petaldance() },
			[1] = new List<Move>() { new Petaldance(), new Petalblizzard(), new Quiverdance(), new Teeterdance(), new Megadrain(), new Aromatherapy(), new Magicalleaf(), new Sleeppowder(), new Gigadrain(), new Leechseed(), new Afteryou(), new Energyball(), new Synthesis(), new Sunnyday(), new Entrainment(), new Leafstorm(), new Absorb(), new Growth(), new Helpinghand(), new Stunspore() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Charm(), new Encore(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Leafblade(), new Leafstorm(), new Lightscreen(), new Magicalleaf(), new Pollenpuff(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Substitute(), new Sunnyday(), new Swordsdance() };
		public override int Weight => 163;
		public override int ExpYield => 168;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}