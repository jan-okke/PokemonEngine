using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Natu : Pokemon
	{
		public override string Name => "Natu";
		public override List<Ability> AvailableAbilities => new() {new Synchronize(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicbounce() };
		public override Stats BaseStats => new Stats(40, 50, 45, 70, 45, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Leer() },
			[5] = new List<Move>() { new Storedpower() },
			[10] = new List<Move>() { new Teleport() },
			[15] = new List<Move>() { new Confuseray() },
			[20] = new List<Move>() { new Nightshade() },
			[26] = new List<Move>() { new Psychoshift() },
			[30] = new List<Move>() { new Powerswap() },
			[35] = new List<Move>() { new Guardswap(), new Psychic() },
			[40] = new List<Move>() { new Wish() },
			[45] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Allyswitch(), new Attract(), new Batonpass(), new Calmmind(), new Cosmicpower(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Dualwingbeat(), new Endure(), new Expandingforce(), new Facade(), new Flash(), new Futuresight(), new Gigadrain(), new Grassknot(), new Guardswap(), new Heatwave(), new Hiddenpower(), new Imprison(), new Lightscreen(), new Magicroom(), new Pluck(), new Powerswap(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Roost(), new Round(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Thunderwave(), new Trick(), new Trickroom(), new Uturn(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Allyswitch(), new Drillpeck(), new Featherdance(), new Haze(), new Quickattack(), new Simplebeam(), new Suckerpunch(), new Zenheadbutt() };
		public override int Weight => 20;
		public override int ExpYield => 64;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}