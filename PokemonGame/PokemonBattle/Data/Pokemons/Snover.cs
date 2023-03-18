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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Snowwarning() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Soundproof() };
		public override Stats BaseStats => new Stats(60, 62, 50, 62, 60, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Powdersnow(), new Moves.Leer() },
			[5] = new List<Move>() { new Moves.Leafage() },
			[10] = new List<Move>() { new Moves.Mist() },
			[15] = new List<Move>() { new Moves.Iceshard() },
			[20] = new List<Move>() { new Moves.Razorleaf() },
			[25] = new List<Move>() { new Moves.Icywind() },
			[30] = new List<Move>() { new Moves.Swagger() },
			[35] = new List<Move>() { new Moves.Ingrain() },
			[41] = new List<Move>() { new Moves.Woodhammer() },
			[45] = new List<Move>() { new Moves.Blizzard() },
			[50] = new List<Move>() { new Moves.Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bulletseed(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Waterpulse(), new Moves.Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Doubleedge(), new Moves.Growth(), new Moves.Leechseed(), new Moves.Magicalleaf(), new Moves.Mist(), new Moves.Seedbomb(), new Moves.Skullbash(), new Moves.Stomp() };
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