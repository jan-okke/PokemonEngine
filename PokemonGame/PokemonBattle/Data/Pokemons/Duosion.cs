using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Duosion : Pokemon
	{
		public override string Name => "Duosion";
		public override List<Ability> AvailableAbilities => new() {new Overcoat(), new Magicguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(65, 40, 50, 30, 125, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Protect(), new Confusion(), new Recover(), new Endeavor() },
			[12] = new List<Move>() { new Psybeam() },
			[16] = new List<Move>() { new Charm() },
			[20] = new List<Move>() { new Psyshock() },
			[24] = new List<Move>() { new Lightscreen(), new Reflect() },
			[28] = new List<Move>() { new Allyswitch() },
			[35] = new List<Move>() { new Painsplit() },
			[40] = new List<Move>() { new Psychic() },
			[46] = new List<Move>() { new Skillswap() },
			[52] = new List<Move>() { new Futuresight() },
			[58] = new List<Move>() { new Wonderroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Charm(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Flashcannon(), new Futuresight(), new Guardswap(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Imprison(), new Irondefense(), new Lightscreen(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Steelroller(), new Storedpower(), new Substitute(), new Thunder(), new Thunderwave(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 80;
		public override int ExpYield => 130;
		public override int CatchRate => 100;
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