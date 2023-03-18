using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Snover : Pokemon
	{
		public override string Name => "Snover";
		public override List<Ability> AvailableAbilities => new() {new Snowwarning() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Soundproof() };
		public override Stats BaseStats => new Stats(60, 62, 50, 40, 62, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powdersnow(), new Leer() },
			[5] = new List<Move>() { new Leafage() },
			[10] = new List<Move>() { new Mist() },
			[15] = new List<Move>() { new Iceshard() },
			[20] = new List<Move>() { new Razorleaf() },
			[25] = new List<Move>() { new Icywind() },
			[30] = new List<Move>() { new Swagger() },
			[35] = new List<Move>() { new Ingrain() },
			[41] = new List<Move>() { new Woodhammer() },
			[45] = new List<Move>() { new Blizzard() },
			[50] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bulletseed(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Hail(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lightscreen(), new Magicalleaf(), new Megapunch(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Swagger(), new Swordsdance(), new Waterpulse(), new Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Doubleedge(), new Growth(), new Leechseed(), new Magicalleaf(), new Mist(), new Seedbomb(), new Skullbash(), new Stomp() };
		public override int Weight => 505;
		public override int ExpYield => 67;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}