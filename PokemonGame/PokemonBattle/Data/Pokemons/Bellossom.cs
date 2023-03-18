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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Healer() };
		public override Stats BaseStats => new Stats(75, 80, 95, 90, 100, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Petalblizzard() },
			[1] = new List<Move>() { new Moves.Petalblizzard(), new Moves.Quiverdance(), new Moves.Megadrain(), new Moves.Poisonpowder(), new Moves.Stunspore(), new Moves.Sleeppowder(), new Moves.Gigadrain(), new Moves.Toxic(), new Moves.Moonblast(), new Moves.Grassyterrain(), new Moves.Moonlight(), new Moves.Petaldance(), new Moves.Absorb(), new Moves.Growth(), new Moves.Acid(), new Moves.Sweetscent() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Bulletseed(), new Moves.Charm(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Magicalleaf(), new Moves.Playrough(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Venoshock() };
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