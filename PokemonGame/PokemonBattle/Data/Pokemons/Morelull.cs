using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Morelull : Pokemon
	{
		public override string Name => "Morelull";
		public override List<Ability> AvailableAbilities => new() {new Illuminate(), new Effectspore() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Raindish() };
		public override Stats BaseStats => new Stats(40, 35, 55, 15, 65, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Astonish() },
			[4] = new List<Move>() { new Confuseray() },
			[8] = new List<Move>() { new Ingrain() },
			[12] = new List<Move>() { new Megadrain() },
			[16] = new List<Move>() { new Sleeppowder() },
			[20] = new List<Move>() { new Moonlight() },
			[25] = new List<Move>() { new Strengthsap() },
			[28] = new List<Move>() { new Gigadrain() },
			[32] = new List<Move>() { new Dazzlinggleam() },
			[36] = new List<Move>() { new Spore() },
			[40] = new List<Move>() { new Moonblast() },
			[44] = new List<Move>() { new Dreameater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Lightscreen(), new Magicroom(), new Pollenpuff(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Thunderwave(), new Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Growth(), new Leechseed(), new Poisonpowder(), new Stunspore() };
		public override int Weight => 15;
		public override int ExpYield => 57;
		public override int CatchRate => 190;
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