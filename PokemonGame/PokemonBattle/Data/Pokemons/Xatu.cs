using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Xatu : Pokemon
	{
		public override string Name => "Xatu";
		public override List<Ability> AvailableAbilities => new() {new Synchronize(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicbounce() };
		public override Stats BaseStats => new Stats(65, 75, 70, 95, 70, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Airslash() },
			[1] = new List<Move>() { new Airslash(), new Tailwind(), new Peck(), new Leer(), new Storedpower(), new Teleport() },
			[15] = new List<Move>() { new Confuseray() },
			[20] = new List<Move>() { new Nightshade() },
			[28] = new List<Move>() { new Psychoshift() },
			[34] = new List<Move>() { new Powerswap(), new Guardswap() },
			[41] = new List<Move>() { new Psychic() },
			[48] = new List<Move>() { new Wish() },
			[55] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Allyswitch(), new Attract(), new Batonpass(), new Calmmind(), new Cosmicpower(), new Dazzlinggleam(), new Defog(), new Doubleteam(), new Dreameater(), new Dualwingbeat(), new Endure(), new Expandingforce(), new Facade(), new Flash(), new Fly(), new Foulplay(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Magicroom(), new Pluck(), new Powerswap(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Roost(), new Round(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Thunderwave(), new Trick(), new Trickroom(), new Uturn(), new Zenheadbutt() };
		public override int Weight => 150;
		public override int ExpYield => 165;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}