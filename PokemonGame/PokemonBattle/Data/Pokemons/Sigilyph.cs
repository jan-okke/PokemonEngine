using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sigilyph : Pokemon
	{
		public override string Name => "Sigilyph";
		public override List<Ability> AvailableAbilities => new() {new Wonderskin(), new Magicguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Tintedlens() };
		public override Stats BaseStats => new Stats(72, 58, 80, 103, 80, 97);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Confusion() },
			[5] = new List<Move>() { new Gravity() },
			[10] = new List<Move>() { new Hypnosis() },
			[15] = new List<Move>() { new Aircutter() },
			[20] = new List<Move>() { new Psybeam() },
			[25] = new List<Move>() { new Whirlwind() },
			[30] = new List<Move>() { new Cosmicpower() },
			[35] = new List<Move>() { new Airslash() },
			[40] = new List<Move>() { new Psychic() },
			[45] = new List<Move>() { new Tailwind() },
			[50] = new List<Move>() { new Lightscreen(), new Reflect() },
			[55] = new List<Move>() { new Skyattack() },
			[60] = new List<Move>() { new Skillswap() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Attract(), new Calmmind(), new Cosmicpower(), new Darkpulse(), new Dazzlinggleam(), new Dualwingbeat(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Flashcannon(), new Fly(), new Futuresight(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Imprison(), new Lightscreen(), new Magicroom(), new Powerswap(), new Protect(), new Psychic(), new Psychocut(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Speedswap(), new Steelwing(), new Storedpower(), new Substitute(), new Swift(), new Thief(), new Thunderwave(), new Trick(), new Trickroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Psychoshift(), new Roost() };
		public override int Weight => 140;
		public override int ExpYield => 172;
		public override int CatchRate => 45;
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