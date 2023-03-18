using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Solosis : Pokemon
	{
		public override string Name => "Solosis";
		public override List<Ability> AvailableAbilities => new() {new Overcoat(), new Magicguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(45, 30, 40, 20, 105, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Protect(), new Confusion() },
			[4] = new List<Move>() { new Recover() },
			[8] = new List<Move>() { new Endeavor() },
			[12] = new List<Move>() { new Psybeam() },
			[16] = new List<Move>() { new Charm() },
			[20] = new List<Move>() { new Psyshock() },
			[24] = new List<Move>() { new Lightscreen(), new Reflect() },
			[28] = new List<Move>() { new Allyswitch() },
			[33] = new List<Move>() { new Painsplit() },
			[36] = new List<Move>() { new Psychic() },
			[40] = new List<Move>() { new Skillswap() },
			[44] = new List<Move>() { new Futuresight() },
			[48] = new List<Move>() { new Wonderroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Charm(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Flashcannon(), new Futuresight(), new Guardswap(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Imprison(), new Irondefense(), new Lightscreen(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Steelroller(), new Storedpower(), new Substitute(), new Thunder(), new Thunderwave(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Acidarmor(), new Astonish(), new Confuseray() };
		public override int Weight => 10;
		public override int ExpYield => 58;
		public override int CatchRate => 200;
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