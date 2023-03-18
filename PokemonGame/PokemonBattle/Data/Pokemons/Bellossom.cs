using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bellossom : Pokemon
	{
		public override string Name => "Bellossom";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Healer() };
		public override Stats BaseStats => new Stats(75, 80, 95, 90, 100, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Petalblizzard() },
			[1] = new List<Move>() { new Petalblizzard(), new Quiverdance(), new Megadrain(), new Poisonpowder(), new Stunspore(), new Sleeppowder(), new Gigadrain(), new Toxic(), new Moonblast(), new Grassyterrain(), new Moonlight(), new Petaldance(), new Absorb(), new Growth(), new Acid(), new Sweetscent() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bulletseed(), new Charm(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fling(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Leafblade(), new Leafstorm(), new Magicalleaf(), new Playrough(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Toxic(), new Uproar(), new Venoshock() };
		public override int Weight => 58;
		public override int ExpYield => 245;
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