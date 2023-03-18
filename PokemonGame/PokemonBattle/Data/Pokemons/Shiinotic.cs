using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shiinotic : Pokemon
	{
		public override string Name => "Shiinotic";
		public override List<Ability> AvailableAbilities => new() {new Illuminate(), new Effectspore() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Raindish() };
		public override Stats BaseStats => new Stats(60, 45, 80, 30, 90, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Astonish(), new Confuseray(), new Ingrain() },
			[12] = new List<Move>() { new Megadrain() },
			[16] = new List<Move>() { new Sleeppowder() },
			[20] = new List<Move>() { new Moonlight() },
			[27] = new List<Move>() { new Strengthsap() },
			[32] = new List<Move>() { new Gigadrain() },
			[38] = new List<Move>() { new Dazzlinggleam() },
			[44] = new List<Move>() { new Spore() },
			[50] = new List<Move>() { new Moonblast() },
			[56] = new List<Move>() { new Dreameater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Dazzlinggleam(), new Drainingkiss(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Magicroom(), new Pollenpuff(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Thunderwave(), new Weatherball(), new Wonderroom() };
		public override int Weight => 115;
		public override int ExpYield => 142;
		public override int CatchRate => 75;
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